using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkArrayIterator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayIterator";

		public new static readonly string MRClassNameKey;

		static vtkArrayIterator()
		{
			vtkArrayIterator.MRClassNameKey = "class vtkArrayIterator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayIterator"));
		}

		public vtkArrayIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkArrayIterator_GetDataType_01(HandleRef pThis);

		public virtual int GetDataType()
		{
			return vtkArrayIterator.vtkArrayIterator_GetDataType_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkArrayIterator_Initialize_02(HandleRef pThis, HandleRef array);

		public virtual void Initialize(vtkAbstractArray array)
		{
			vtkArrayIterator.vtkArrayIterator_Initialize_02(base.GetCppThis(), (array == null) ? default(HandleRef) : array.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkArrayIterator_IsA_03(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkArrayIterator.vtkArrayIterator_IsA_03(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkArrayIterator_IsTypeOf_04(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkArrayIterator.vtkArrayIterator_IsTypeOf_04(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayIterator_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkArrayIterator NewInstance()
		{
			vtkArrayIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayIterator.vtkArrayIterator_NewInstance_05(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkArrayIterator_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkArrayIterator SafeDownCast(vtkObjectBase o)
		{
			vtkArrayIterator vtkArrayIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkArrayIterator.vtkArrayIterator_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayIterator = (vtkArrayIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayIterator.Register(null);
				}
			}
			return vtkArrayIterator;
		}
	}
}
