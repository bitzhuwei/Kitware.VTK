using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDashedStreamLine : vtkStreamLine
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDashedStreamLine";

		public new static readonly string MRClassNameKey;

		static vtkDashedStreamLine()
		{
			vtkDashedStreamLine.MRClassNameKey = "class vtkDashedStreamLine";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDashedStreamLine.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDashedStreamLine"));
		}

		public vtkDashedStreamLine(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDashedStreamLine_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDashedStreamLine New()
		{
			vtkDashedStreamLine result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDashedStreamLine.vtkDashedStreamLine_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDashedStreamLine)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDashedStreamLine() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDashedStreamLine.vtkDashedStreamLine_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDashedStreamLine_GetDashFactor_01(HandleRef pThis);

		public virtual double GetDashFactor()
		{
			return vtkDashedStreamLine.vtkDashedStreamLine_GetDashFactor_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDashedStreamLine_GetDashFactorMaxValue_02(HandleRef pThis);

		public virtual double GetDashFactorMaxValue()
		{
			return vtkDashedStreamLine.vtkDashedStreamLine_GetDashFactorMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkDashedStreamLine_GetDashFactorMinValue_03(HandleRef pThis);

		public virtual double GetDashFactorMinValue()
		{
			return vtkDashedStreamLine.vtkDashedStreamLine_GetDashFactorMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDashedStreamLine_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDashedStreamLine.vtkDashedStreamLine_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkDashedStreamLine_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDashedStreamLine.vtkDashedStreamLine_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDashedStreamLine_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDashedStreamLine NewInstance()
		{
			vtkDashedStreamLine result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDashedStreamLine.vtkDashedStreamLine_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDashedStreamLine)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkDashedStreamLine_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDashedStreamLine SafeDownCast(vtkObjectBase o)
		{
			vtkDashedStreamLine vtkDashedStreamLine = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDashedStreamLine.vtkDashedStreamLine_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDashedStreamLine = (vtkDashedStreamLine)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDashedStreamLine.Register(null);
				}
			}
			return vtkDashedStreamLine;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkDashedStreamLine_SetDashFactor_09(HandleRef pThis, double _arg);

		public virtual void SetDashFactor(double _arg)
		{
			vtkDashedStreamLine.vtkDashedStreamLine_SetDashFactor_09(base.GetCppThis(), _arg);
		}
	}
}
