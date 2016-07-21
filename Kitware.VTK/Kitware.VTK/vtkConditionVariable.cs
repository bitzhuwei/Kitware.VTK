using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkConditionVariable : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkConditionVariable";

		public new static readonly string MRClassNameKey;

		static vtkConditionVariable()
		{
			vtkConditionVariable.MRClassNameKey = "class vtkConditionVariable";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkConditionVariable.MRClassNameKey, Type.GetType("Kitware.VTK.vtkConditionVariable"));
		}

		public vtkConditionVariable(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkConditionVariable_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkConditionVariable New()
		{
			vtkConditionVariable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConditionVariable.vtkConditionVariable_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConditionVariable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkConditionVariable() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkConditionVariable.vtkConditionVariable_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkConditionVariable_Broadcast_01(HandleRef pThis);

		public void Broadcast()
		{
			vtkConditionVariable.vtkConditionVariable_Broadcast_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkConditionVariable_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkConditionVariable.vtkConditionVariable_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkConditionVariable_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkConditionVariable.vtkConditionVariable_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkConditionVariable_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkConditionVariable NewInstance()
		{
			vtkConditionVariable result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConditionVariable.vtkConditionVariable_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkConditionVariable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkConditionVariable_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkConditionVariable SafeDownCast(vtkObjectBase o)
		{
			vtkConditionVariable vtkConditionVariable = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkConditionVariable.vtkConditionVariable_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkConditionVariable = (vtkConditionVariable)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkConditionVariable.Register(null);
				}
			}
			return vtkConditionVariable;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkConditionVariable_Signal_07(HandleRef pThis);

		public void Signal()
		{
			vtkConditionVariable.vtkConditionVariable_Signal_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkConditionVariable_Wait_08(HandleRef pThis, HandleRef arg0);

		public int Wait(vtkMutexLock arg0)
		{
			return vtkConditionVariable.vtkConditionVariable_Wait_08(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
