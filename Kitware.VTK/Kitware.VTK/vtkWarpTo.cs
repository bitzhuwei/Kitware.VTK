using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkWarpTo : vtkPointSetAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkWarpTo";

		public new static readonly string MRClassNameKey;

		static vtkWarpTo()
		{
			vtkWarpTo.MRClassNameKey = "class vtkWarpTo";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkWarpTo.MRClassNameKey, Type.GetType("Kitware.VTK.vtkWarpTo"));
		}

		public vtkWarpTo(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpTo_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWarpTo New()
		{
			vtkWarpTo result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWarpTo.vtkWarpTo_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpTo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkWarpTo() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkWarpTo.vtkWarpTo_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpTo_AbsoluteOff_01(HandleRef pThis);

		public virtual void AbsoluteOff()
		{
			vtkWarpTo.vtkWarpTo_AbsoluteOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpTo_AbsoluteOn_02(HandleRef pThis);

		public virtual void AbsoluteOn()
		{
			vtkWarpTo.vtkWarpTo_AbsoluteOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWarpTo_GetAbsolute_03(HandleRef pThis);

		public virtual int GetAbsolute()
		{
			return vtkWarpTo.vtkWarpTo_GetAbsolute_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpTo_GetPosition_04(HandleRef pThis);

		public virtual double[] GetPosition()
		{
			IntPtr intPtr = vtkWarpTo.vtkWarpTo_GetPosition_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpTo_GetPosition_05(HandleRef pThis, IntPtr data);

		public virtual void GetPosition(IntPtr data)
		{
			vtkWarpTo.vtkWarpTo_GetPosition_05(base.GetCppThis(), data);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern double vtkWarpTo_GetScaleFactor_06(HandleRef pThis);

		public virtual double GetScaleFactor()
		{
			return vtkWarpTo.vtkWarpTo_GetScaleFactor_06(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWarpTo_IsA_07(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkWarpTo.vtkWarpTo_IsA_07(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern int vtkWarpTo_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkWarpTo.vtkWarpTo_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpTo_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkWarpTo NewInstance()
		{
			vtkWarpTo result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWarpTo.vtkWarpTo_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkWarpTo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern IntPtr vtkWarpTo_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkWarpTo SafeDownCast(vtkObjectBase o)
		{
			vtkWarpTo vtkWarpTo = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkWarpTo.vtkWarpTo_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkWarpTo = (vtkWarpTo)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkWarpTo.Register(null);
				}
			}
			return vtkWarpTo;
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpTo_SetAbsolute_12(HandleRef pThis, int _arg);

		public virtual void SetAbsolute(int _arg)
		{
			vtkWarpTo.vtkWarpTo_SetAbsolute_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpTo_SetPosition_13(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		public virtual void SetPosition(double _arg1, double _arg2, double _arg3)
		{
			vtkWarpTo.vtkWarpTo_SetPosition_13(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpTo_SetPosition_14(HandleRef pThis, IntPtr _arg);

		public virtual void SetPosition(IntPtr _arg)
		{
			vtkWarpTo.vtkWarpTo_SetPosition_14(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkGraphics.Unmanaged.dll")]
		internal static extern void vtkWarpTo_SetScaleFactor_15(HandleRef pThis, double _arg);

		public virtual void SetScaleFactor(double _arg)
		{
			vtkWarpTo.vtkWarpTo_SetScaleFactor_15(base.GetCppThis(), _arg);
		}
	}
}
