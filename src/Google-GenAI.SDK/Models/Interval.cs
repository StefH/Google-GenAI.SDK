﻿namespace GoogleGenAI.SDK.Models;

/// <summary>
/// Represents a time interval, encoded as a Timestamp start (inclusive) and a Timestamp end (exclusive).  The start must be less than or equal to the end. When the start equals the end, the interval is empty (matches no time). When both start and end are unspecified, the interval matches any time.
/// </summary>
public class Interval
{
    /// <summary>
    /// Optional. Exclusive end of the interval.  If specified, a Timestamp matching this interval will have to be before the end.
    /// </summary>
    public System.DateTime? EndTime { get; init; }

    /// <summary>
    /// Optional. Inclusive start of the interval.  If specified, a Timestamp matching this interval will have to be the same or after the start.
    /// </summary>
    public System.DateTime? StartTime { get; init; }
}