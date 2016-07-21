using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageQuantizeRGBToIndex : vtkImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageQuantizeRGBToIndex";

		public new static readonly string MRClassNameKey;

		static vtkImageQuantizeRGBToIndex()
		{
			vtkImageQuantizeRGBToIndex.MRClassNameKey = "class vtkImageQuantizeRGBToIndex";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageQuantizeRGBToIndex.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageQuantizeRGBToIndex"));
		}

		public vtkImageQuantizeRGBToIndex(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageQuantizeRGBToIndex_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageQuantizeRGBToIndex New()
		{
			vtkImageQuantizeRGBToIndex result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageQuantizeRGBToIndex)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageQuantizeRGBToIndex() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageQuantizeRGBToIndex_GetBuildTreeExecuteTime_01(HandleRef pThis);

		public virtual double GetBuildTreeExecuteTime()
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetBuildTreeExecuteTime_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageQuantizeRGBToIndex_GetInitializeExecuteTime_02(HandleRef pThis);

		public virtual double GetInitializeExecuteTime()
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetInitializeExecuteTime_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageQuantizeRGBToIndex_GetInputType_03(HandleRef pThis);

		public virtual int GetInputType()
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetInputType_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern double vtkImageQuantizeRGBToIndex_GetLookupIndexExecuteTime_04(HandleRef pThis);

		public virtual double GetLookupIndexExecuteTime()
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetLookupIndexExecuteTime_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageQuantizeRGBToIndex_GetLookupTable_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkLookupTable GetLookupTable()
		{
			vtkLookupTable vtkLookupTable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetLookupTable_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLookupTable = (vtkLookupTable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLookupTable.Register(null);
				}
			}
			return vtkLookupTable;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageQuantizeRGBToIndex_GetNumberOfColors_06(HandleRef pThis);

		public virtual int GetNumberOfColors()
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetNumberOfColors_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageQuantizeRGBToIndex_GetNumberOfColorsMaxValue_07(HandleRef pThis);

		public virtual int GetNumberOfColorsMaxValue()
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetNumberOfColorsMaxValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageQuantizeRGBToIndex_GetNumberOfColorsMinValue_08(HandleRef pThis);

		public virtual int GetNumberOfColorsMinValue()
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_GetNumberOfColorsMinValue_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageQuantizeRGBToIndex_IsA_09(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_IsA_09(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageQuantizeRGBToIndex_IsTypeOf_10(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_IsTypeOf_10(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageQuantizeRGBToIndex_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageQuantizeRGBToIndex NewInstance()
		{
			vtkImageQuantizeRGBToIndex result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_NewInstance_12(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageQuantizeRGBToIndex)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageQuantizeRGBToIndex_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageQuantizeRGBToIndex SafeDownCast(vtkObjectBase o)
		{
			vtkImageQuantizeRGBToIndex vtkImageQuantizeRGBToIndex = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageQuantizeRGBToIndex = (vtkImageQuantizeRGBToIndex)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageQuantizeRGBToIndex.Register(null);
				}
			}
			return vtkImageQuantizeRGBToIndex;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageQuantizeRGBToIndex_SetBuildTreeExecuteTime_14(HandleRef pThis, double _arg);

		public virtual void SetBuildTreeExecuteTime(double _arg)
		{
			vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_SetBuildTreeExecuteTime_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageQuantizeRGBToIndex_SetInitializeExecuteTime_15(HandleRef pThis, double _arg);

		public virtual void SetInitializeExecuteTime(double _arg)
		{
			vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_SetInitializeExecuteTime_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageQuantizeRGBToIndex_SetLookupIndexExecuteTime_16(HandleRef pThis, double _arg);

		public virtual void SetLookupIndexExecuteTime(double _arg)
		{
			vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_SetLookupIndexExecuteTime_16(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageQuantizeRGBToIndex_SetNumberOfColors_17(HandleRef pThis, int _arg);

		public virtual void SetNumberOfColors(int _arg)
		{
			vtkImageQuantizeRGBToIndex.vtkImageQuantizeRGBToIndex_SetNumberOfColors_17(base.GetCppThis(), _arg);
		}
	}
}
