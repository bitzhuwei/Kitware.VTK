using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkPassThrough : vtkPassInputTypeAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkPassThrough";

		public new static readonly string MRClassNameKey;

		static vtkPassThrough()
		{
			vtkPassThrough.MRClassNameKey = "class vtkPassThrough";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPassThrough.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPassThrough"));
		}

		public vtkPassThrough(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPassThrough_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPassThrough New()
		{
			vtkPassThrough result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPassThrough.vtkPassThrough_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassThrough)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkPassThrough() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkPassThrough.vtkPassThrough_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPassThrough_DeepCopyInputOff_01(HandleRef pThis);

		public virtual void DeepCopyInputOff()
		{
			vtkPassThrough.vtkPassThrough_DeepCopyInputOff_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPassThrough_DeepCopyInputOn_02(HandleRef pThis);

		public virtual void DeepCopyInputOn()
		{
			vtkPassThrough.vtkPassThrough_DeepCopyInputOn_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPassThrough_FillInputPortInformation_03(HandleRef pThis, int port, HandleRef info);

		public virtual int FillInputPortInformation(int port, vtkInformation info)
		{
			return vtkPassThrough.vtkPassThrough_FillInputPortInformation_03(base.GetCppThis(), port, (info == null) ? default(HandleRef) : info.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPassThrough_GetDeepCopyInput_04(HandleRef pThis);

		public virtual int GetDeepCopyInput()
		{
			return vtkPassThrough.vtkPassThrough_GetDeepCopyInput_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPassThrough_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkPassThrough.vtkPassThrough_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern int vtkPassThrough_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkPassThrough.vtkPassThrough_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPassThrough_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkPassThrough NewInstance()
		{
			vtkPassThrough result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPassThrough.vtkPassThrough_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPassThrough)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern IntPtr vtkPassThrough_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkPassThrough SafeDownCast(vtkObjectBase o)
		{
			vtkPassThrough vtkPassThrough = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkPassThrough.vtkPassThrough_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPassThrough = (vtkPassThrough)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPassThrough.Register(null);
				}
			}
			return vtkPassThrough;
		}

		[DllImport("Kitware.VTK.vtkInfovis.Unmanaged.dll")]
		internal static extern void vtkPassThrough_SetDeepCopyInput_10(HandleRef pThis, int _arg);

		public virtual void SetDeepCopyInput(int _arg)
		{
			vtkPassThrough.vtkPassThrough_SetDeepCopyInput_10(base.GetCppThis(), _arg);
		}
	}
}
