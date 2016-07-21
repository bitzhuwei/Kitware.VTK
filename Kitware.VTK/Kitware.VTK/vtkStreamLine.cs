using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkStreamLine : vtkStreamer
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStreamLine";

		public new static readonly string MRClassNameKey;

		static vtkStreamLine()
		{
			vtkStreamLine.MRClassNameKey = "class vtkStreamLine";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStreamLine.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreamLine"));
		}

		public vtkStreamLine(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamLine_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStreamLine New()
		{
			vtkStreamLine result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamLine.vtkStreamLine_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamLine)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkStreamLine() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkStreamLine.vtkStreamLine_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamLine_GetStepLength_01(HandleRef pThis);

		public virtual double GetStepLength()
		{
			return vtkStreamLine.vtkStreamLine_GetStepLength_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamLine_GetStepLengthMaxValue_02(HandleRef pThis);

		public virtual double GetStepLengthMaxValue()
		{
			return vtkStreamLine.vtkStreamLine_GetStepLengthMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkStreamLine_GetStepLengthMinValue_03(HandleRef pThis);

		public virtual double GetStepLengthMinValue()
		{
			return vtkStreamLine.vtkStreamLine_GetStepLengthMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamLine_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStreamLine.vtkStreamLine_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkStreamLine_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStreamLine.vtkStreamLine_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamLine_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStreamLine NewInstance()
		{
			vtkStreamLine result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamLine.vtkStreamLine_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreamLine)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkStreamLine_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStreamLine SafeDownCast(vtkObjectBase o)
		{
			vtkStreamLine vtkStreamLine = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStreamLine.vtkStreamLine_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStreamLine = (vtkStreamLine)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStreamLine.Register(null);
				}
			}
			return vtkStreamLine;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkStreamLine_SetStepLength_09(HandleRef pThis, double _arg);

		public virtual void SetStepLength(double _arg)
		{
			vtkStreamLine.vtkStreamLine_SetStepLength_09(base.GetCppThis(), _arg);
		}
	}
}
