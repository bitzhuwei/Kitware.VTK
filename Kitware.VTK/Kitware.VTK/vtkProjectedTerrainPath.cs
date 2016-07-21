using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkProjectedTerrainPath : vtkPolyDataAlgorithm
	{
		public enum HUG_PROJECTION_WrapperEnum
		{
			HUG_PROJECTION = 2,
			NONOCCLUDED_PROJECTION = 1,
			SIMPLE_PROJECTION = 0
		}

		public new const string MRFullTypeName = "Kitware.VTK.vtkProjectedTerrainPath";

		public new static readonly string MRClassNameKey;

		static vtkProjectedTerrainPath()
		{
			vtkProjectedTerrainPath.MRClassNameKey = "class vtkProjectedTerrainPath";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkProjectedTerrainPath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkProjectedTerrainPath"));
		}

		public vtkProjectedTerrainPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTerrainPath_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProjectedTerrainPath New()
		{
			vtkProjectedTerrainPath result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProjectedTerrainPath.vtkProjectedTerrainPath_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectedTerrainPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkProjectedTerrainPath() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkProjectedTerrainPath.vtkProjectedTerrainPath_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkProjectedTerrainPath_GetHeightOffset_01(HandleRef pThis);

		public virtual double GetHeightOffset()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetHeightOffset_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkProjectedTerrainPath_GetHeightTolerance_02(HandleRef pThis);

		public virtual double GetHeightTolerance()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetHeightTolerance_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkProjectedTerrainPath_GetHeightToleranceMaxValue_03(HandleRef pThis);

		public virtual double GetHeightToleranceMaxValue()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetHeightToleranceMaxValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkProjectedTerrainPath_GetHeightToleranceMinValue_04(HandleRef pThis);

		public virtual double GetHeightToleranceMinValue()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetHeightToleranceMinValue_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkProjectedTerrainPath_GetMaximumNumberOfLines_05(HandleRef pThis);

		public virtual long GetMaximumNumberOfLines()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetMaximumNumberOfLines_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkProjectedTerrainPath_GetMaximumNumberOfLinesMaxValue_06(HandleRef pThis);

		public virtual long GetMaximumNumberOfLinesMaxValue()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetMaximumNumberOfLinesMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern long vtkProjectedTerrainPath_GetMaximumNumberOfLinesMinValue_07(HandleRef pThis);

		public virtual long GetMaximumNumberOfLinesMinValue()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetMaximumNumberOfLinesMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkProjectedTerrainPath_GetProjectionMode_08(HandleRef pThis);

		public virtual int GetProjectionMode()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetProjectionMode_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkProjectedTerrainPath_GetProjectionModeMaxValue_09(HandleRef pThis);

		public virtual int GetProjectionModeMaxValue()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetProjectionModeMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkProjectedTerrainPath_GetProjectionModeMinValue_10(HandleRef pThis);

		public virtual int GetProjectionModeMinValue()
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetProjectionModeMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTerrainPath_GetSource_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public vtkImageData GetSource()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProjectedTerrainPath.vtkProjectedTerrainPath_GetSource_11(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkProjectedTerrainPath_IsA_12(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_IsA_12(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkProjectedTerrainPath_IsTypeOf_13(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkProjectedTerrainPath.vtkProjectedTerrainPath_IsTypeOf_13(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTerrainPath_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkProjectedTerrainPath NewInstance()
		{
			vtkProjectedTerrainPath result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProjectedTerrainPath.vtkProjectedTerrainPath_NewInstance_15(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkProjectedTerrainPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkProjectedTerrainPath_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkProjectedTerrainPath SafeDownCast(vtkObjectBase o)
		{
			vtkProjectedTerrainPath vtkProjectedTerrainPath = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkProjectedTerrainPath.vtkProjectedTerrainPath_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkProjectedTerrainPath = (vtkProjectedTerrainPath)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkProjectedTerrainPath.Register(null);
				}
			}
			return vtkProjectedTerrainPath;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkProjectedTerrainPath_SetHeightOffset_17(HandleRef pThis, double _arg);

		public virtual void SetHeightOffset(double _arg)
		{
			vtkProjectedTerrainPath.vtkProjectedTerrainPath_SetHeightOffset_17(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkProjectedTerrainPath_SetHeightTolerance_18(HandleRef pThis, double _arg);

		public virtual void SetHeightTolerance(double _arg)
		{
			vtkProjectedTerrainPath.vtkProjectedTerrainPath_SetHeightTolerance_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkProjectedTerrainPath_SetMaximumNumberOfLines_19(HandleRef pThis, long _arg);

		public virtual void SetMaximumNumberOfLines(long _arg)
		{
			vtkProjectedTerrainPath.vtkProjectedTerrainPath_SetMaximumNumberOfLines_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkProjectedTerrainPath_SetProjectionMode_20(HandleRef pThis, int _arg);

		public virtual void SetProjectionMode(int _arg)
		{
			vtkProjectedTerrainPath.vtkProjectedTerrainPath_SetProjectionMode_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkProjectedTerrainPath_SetProjectionModeToHug_21(HandleRef pThis);

		public void SetProjectionModeToHug()
		{
			vtkProjectedTerrainPath.vtkProjectedTerrainPath_SetProjectionModeToHug_21(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkProjectedTerrainPath_SetProjectionModeToNonOccluded_22(HandleRef pThis);

		public void SetProjectionModeToNonOccluded()
		{
			vtkProjectedTerrainPath.vtkProjectedTerrainPath_SetProjectionModeToNonOccluded_22(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkProjectedTerrainPath_SetProjectionModeToSimple_23(HandleRef pThis);

		public void SetProjectionModeToSimple()
		{
			vtkProjectedTerrainPath.vtkProjectedTerrainPath_SetProjectionModeToSimple_23(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkProjectedTerrainPath_SetSource_24(HandleRef pThis, HandleRef source);

		public void SetSource(vtkImageData source)
		{
			vtkProjectedTerrainPath.vtkProjectedTerrainPath_SetSource_24(base.GetCppThis(), (source == null) ? default(HandleRef) : source.GetCppThis());
		}
	}
}
