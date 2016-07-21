using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkDummyCommunicator : vtkCommunicator
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkDummyCommunicator";

		public new static readonly string MRClassNameKey;

		static vtkDummyCommunicator()
		{
			vtkDummyCommunicator.MRClassNameKey = "class vtkDummyCommunicator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDummyCommunicator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDummyCommunicator"));
		}

		public vtkDummyCommunicator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDummyCommunicator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDummyCommunicator New()
		{
			vtkDummyCommunicator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDummyCommunicator.vtkDummyCommunicator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDummyCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkDummyCommunicator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkDummyCommunicator.vtkDummyCommunicator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkDummyCommunicator_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkDummyCommunicator.vtkDummyCommunicator_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkDummyCommunicator_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkDummyCommunicator.vtkDummyCommunicator_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDummyCommunicator_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkDummyCommunicator NewInstance()
		{
			vtkDummyCommunicator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDummyCommunicator.vtkDummyCommunicator_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDummyCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkDummyCommunicator_ReceiveVoidArray_05(HandleRef pThis, IntPtr arg0, long arg1, int arg2, int arg3, int arg4);

		public override int ReceiveVoidArray(IntPtr arg0, long arg1, int arg2, int arg3, int arg4)
		{
			return vtkDummyCommunicator.vtkDummyCommunicator_ReceiveVoidArray_05(base.GetCppThis(), arg0, arg1, arg2, arg3, arg4);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkDummyCommunicator_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkDummyCommunicator SafeDownCast(vtkObjectBase o)
		{
			vtkDummyCommunicator vtkDummyCommunicator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkDummyCommunicator.vtkDummyCommunicator_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDummyCommunicator = (vtkDummyCommunicator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDummyCommunicator.Register(null);
				}
			}
			return vtkDummyCommunicator;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkDummyCommunicator_SendVoidArray_07(HandleRef pThis, IntPtr arg0, long arg1, int arg2, int arg3, int arg4);

		public override int SendVoidArray(IntPtr arg0, long arg1, int arg2, int arg3, int arg4)
		{
			return vtkDummyCommunicator.vtkDummyCommunicator_SendVoidArray_07(base.GetCppThis(), arg0, arg1, arg2, arg3, arg4);
		}
	}
}
