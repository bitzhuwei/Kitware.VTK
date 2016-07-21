using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkMaskPolyData : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkMaskPolyData";

		public new static readonly string MRClassNameKey;

		static vtkMaskPolyData()
		{
			vtkMaskPolyData.MRClassNameKey = "class vtkMaskPolyData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkMaskPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkMaskPolyData"));
		}

		public vtkMaskPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMaskPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMaskPolyData New()
		{
			vtkMaskPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMaskPolyData.vtkMaskPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMaskPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkMaskPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkMaskPolyData.vtkMaskPolyData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkMaskPolyData_GetOffset_01(HandleRef pThis);

		public virtual long GetOffset()
		{
			return vtkMaskPolyData.vtkMaskPolyData_GetOffset_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkMaskPolyData_GetOffsetMaxValue_02(HandleRef pThis);

		public virtual long GetOffsetMaxValue()
		{
			return vtkMaskPolyData.vtkMaskPolyData_GetOffsetMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern long vtkMaskPolyData_GetOffsetMinValue_03(HandleRef pThis);

		public virtual long GetOffsetMinValue()
		{
			return vtkMaskPolyData.vtkMaskPolyData_GetOffsetMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMaskPolyData_GetOnRatio_04(HandleRef pThis);

		public virtual int GetOnRatio()
		{
			return vtkMaskPolyData.vtkMaskPolyData_GetOnRatio_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMaskPolyData_GetOnRatioMaxValue_05(HandleRef pThis);

		public virtual int GetOnRatioMaxValue()
		{
			return vtkMaskPolyData.vtkMaskPolyData_GetOnRatioMaxValue_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMaskPolyData_GetOnRatioMinValue_06(HandleRef pThis);

		public virtual int GetOnRatioMinValue()
		{
			return vtkMaskPolyData.vtkMaskPolyData_GetOnRatioMinValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMaskPolyData_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkMaskPolyData.vtkMaskPolyData_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkMaskPolyData_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkMaskPolyData.vtkMaskPolyData_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMaskPolyData_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkMaskPolyData NewInstance()
		{
			vtkMaskPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMaskPolyData.vtkMaskPolyData_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkMaskPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkMaskPolyData_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkMaskPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkMaskPolyData vtkMaskPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkMaskPolyData.vtkMaskPolyData_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMaskPolyData = (vtkMaskPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMaskPolyData.Register(null);
				}
			}
			return vtkMaskPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskPolyData_SetOffset_12(HandleRef pThis, long _arg);

		public virtual void SetOffset(long _arg)
		{
			vtkMaskPolyData.vtkMaskPolyData_SetOffset_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkMaskPolyData_SetOnRatio_13(HandleRef pThis, int _arg);

		public virtual void SetOnRatio(int _arg)
		{
			vtkMaskPolyData.vtkMaskPolyData_SetOnRatio_13(base.GetCppThis(), _arg);
		}
	}
}
