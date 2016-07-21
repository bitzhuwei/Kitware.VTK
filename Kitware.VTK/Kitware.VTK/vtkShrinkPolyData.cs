using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkShrinkPolyData : vtkPolyDataAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkShrinkPolyData";

		public new static readonly string MRClassNameKey;

		static vtkShrinkPolyData()
		{
			vtkShrinkPolyData.MRClassNameKey = "class vtkShrinkPolyData";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkShrinkPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkShrinkPolyData"));
		}

		public vtkShrinkPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkShrinkPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkShrinkPolyData New()
		{
			vtkShrinkPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShrinkPolyData.vtkShrinkPolyData_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShrinkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkShrinkPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkShrinkPolyData.vtkShrinkPolyData_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkShrinkPolyData_GetShrinkFactor_01(HandleRef pThis);

		public virtual double GetShrinkFactor()
		{
			return vtkShrinkPolyData.vtkShrinkPolyData_GetShrinkFactor_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkShrinkPolyData_GetShrinkFactorMaxValue_02(HandleRef pThis);

		public virtual double GetShrinkFactorMaxValue()
		{
			return vtkShrinkPolyData.vtkShrinkPolyData_GetShrinkFactorMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkShrinkPolyData_GetShrinkFactorMinValue_03(HandleRef pThis);

		public virtual double GetShrinkFactorMinValue()
		{
			return vtkShrinkPolyData.vtkShrinkPolyData_GetShrinkFactorMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkShrinkPolyData_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkShrinkPolyData.vtkShrinkPolyData_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkShrinkPolyData_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkShrinkPolyData.vtkShrinkPolyData_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkShrinkPolyData_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkShrinkPolyData NewInstance()
		{
			vtkShrinkPolyData result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShrinkPolyData.vtkShrinkPolyData_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkShrinkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkShrinkPolyData_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkShrinkPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkShrinkPolyData vtkShrinkPolyData = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkShrinkPolyData.vtkShrinkPolyData_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkShrinkPolyData = (vtkShrinkPolyData)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkShrinkPolyData.Register(null);
				}
			}
			return vtkShrinkPolyData;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkShrinkPolyData_SetShrinkFactor_09(HandleRef pThis, double _arg);

		public virtual void SetShrinkFactor(double _arg)
		{
			vtkShrinkPolyData.vtkShrinkPolyData_SetShrinkFactor_09(base.GetCppThis(), _arg);
		}
	}
}
