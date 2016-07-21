using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkX3DExporter : vtkExporter
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkX3DExporter";

		public new static readonly string MRClassNameKey;

		static vtkX3DExporter()
		{
			vtkX3DExporter.MRClassNameKey = "class vtkX3DExporter";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkX3DExporter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkX3DExporter"));
		}

		public vtkX3DExporter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkX3DExporter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkX3DExporter New()
		{
			vtkX3DExporter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkX3DExporter.vtkX3DExporter_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkX3DExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkX3DExporter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkX3DExporter.vtkX3DExporter_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkX3DExporter_BinaryOff_01(HandleRef pThis);

		public virtual void BinaryOff()
		{
			vtkX3DExporter.vtkX3DExporter_BinaryOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkX3DExporter_BinaryOn_02(HandleRef pThis);

		public virtual void BinaryOn()
		{
			vtkX3DExporter.vtkX3DExporter_BinaryOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkX3DExporter_FastestOff_03(HandleRef pThis);

		public virtual void FastestOff()
		{
			vtkX3DExporter.vtkX3DExporter_FastestOff_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkX3DExporter_FastestOn_04(HandleRef pThis);

		public virtual void FastestOn()
		{
			vtkX3DExporter.vtkX3DExporter_FastestOn_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkX3DExporter_GetBinary_05(HandleRef pThis);

		public virtual int GetBinary()
		{
			return vtkX3DExporter.vtkX3DExporter_GetBinary_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkX3DExporter_GetBinaryMaxValue_06(HandleRef pThis);

		public virtual int GetBinaryMaxValue()
		{
			return vtkX3DExporter.vtkX3DExporter_GetBinaryMaxValue_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkX3DExporter_GetBinaryMinValue_07(HandleRef pThis);

		public virtual int GetBinaryMinValue()
		{
			return vtkX3DExporter.vtkX3DExporter_GetBinaryMinValue_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkX3DExporter_GetFastest_08(HandleRef pThis);

		public virtual int GetFastest()
		{
			return vtkX3DExporter.vtkX3DExporter_GetFastest_08(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkX3DExporter_GetFastestMaxValue_09(HandleRef pThis);

		public virtual int GetFastestMaxValue()
		{
			return vtkX3DExporter.vtkX3DExporter_GetFastestMaxValue_09(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkX3DExporter_GetFastestMinValue_10(HandleRef pThis);

		public virtual int GetFastestMinValue()
		{
			return vtkX3DExporter.vtkX3DExporter_GetFastestMinValue_10(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkX3DExporter_GetFileName_11(HandleRef pThis);

		public virtual string GetFileName()
		{
			return Marshal.PtrToStringAnsi(vtkX3DExporter.vtkX3DExporter_GetFileName_11(base.GetCppThis()));
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern double vtkX3DExporter_GetSpeed_12(HandleRef pThis);

		public virtual double GetSpeed()
		{
			return vtkX3DExporter.vtkX3DExporter_GetSpeed_12(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkX3DExporter_IsA_13(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkX3DExporter.vtkX3DExporter_IsA_13(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern int vtkX3DExporter_IsTypeOf_14(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkX3DExporter.vtkX3DExporter_IsTypeOf_14(type);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkX3DExporter_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkX3DExporter NewInstance()
		{
			vtkX3DExporter result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkX3DExporter.vtkX3DExporter_NewInstance_16(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkX3DExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern IntPtr vtkX3DExporter_SafeDownCast_17(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkX3DExporter SafeDownCast(vtkObjectBase o)
		{
			vtkX3DExporter vtkX3DExporter = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkX3DExporter.vtkX3DExporter_SafeDownCast_17((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkX3DExporter = (vtkX3DExporter)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkX3DExporter.Register(null);
				}
			}
			return vtkX3DExporter;
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkX3DExporter_SetBinary_18(HandleRef pThis, int _arg);

		public virtual void SetBinary(int _arg)
		{
			vtkX3DExporter.vtkX3DExporter_SetBinary_18(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkX3DExporter_SetFastest_19(HandleRef pThis, int _arg);

		public virtual void SetFastest(int _arg)
		{
			vtkX3DExporter.vtkX3DExporter_SetFastest_19(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkX3DExporter_SetFileName_20(HandleRef pThis, string _arg);

		public virtual void SetFileName(string _arg)
		{
			vtkX3DExporter.vtkX3DExporter_SetFileName_20(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkHybrid.Unmanaged.dll")]
		internal static extern void vtkX3DExporter_SetSpeed_21(HandleRef pThis, double _arg);

		public virtual void SetSpeed(double _arg)
		{
			vtkX3DExporter.vtkX3DExporter_SetSpeed_21(base.GetCppThis(), _arg);
		}
	}
}
