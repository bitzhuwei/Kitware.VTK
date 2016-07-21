using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkInformationIterator : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationIterator";

		public new static readonly string MRClassNameKey;

		static vtkInformationIterator()
		{
			vtkInformationIterator.MRClassNameKey = "class vtkInformationIterator";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationIterator"));
		}

		public vtkInformationIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationIterator_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationIterator New()
		{
			vtkInformationIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationIterator.vtkInformationIterator_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkInformationIterator() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkInformationIterator.vtkInformationIterator_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationIterator_GetCurrentKey_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkInformationKey GetCurrentKey()
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationIterator.vtkInformationIterator_GetCurrentKey_01(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationIterator_GetInformation_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public virtual vtkInformation GetInformation()
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationIterator.vtkInformationIterator_GetInformation_02(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationIterator_GoToFirstItem_03(HandleRef pThis);

		public virtual void GoToFirstItem()
		{
			vtkInformationIterator.vtkInformationIterator_GoToFirstItem_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationIterator_GoToNextItem_04(HandleRef pThis);

		public virtual void GoToNextItem()
		{
			vtkInformationIterator.vtkInformationIterator_GoToNextItem_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationIterator_InitTraversal_05(HandleRef pThis);

		public void InitTraversal()
		{
			vtkInformationIterator.vtkInformationIterator_InitTraversal_05(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationIterator_IsA_06(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkInformationIterator.vtkInformationIterator_IsA_06(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationIterator_IsDoneWithTraversal_07(HandleRef pThis);

		public virtual int IsDoneWithTraversal()
		{
			return vtkInformationIterator.vtkInformationIterator_IsDoneWithTraversal_07(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern int vtkInformationIterator_IsTypeOf_08(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkInformationIterator.vtkInformationIterator_IsTypeOf_08(type);
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationIterator_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkInformationIterator NewInstance()
		{
			vtkInformationIterator result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationIterator.vtkInformationIterator_NewInstance_10(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern IntPtr vtkInformationIterator_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkInformationIterator SafeDownCast(vtkObjectBase o)
		{
			vtkInformationIterator vtkInformationIterator = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkInformationIterator.vtkInformationIterator_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIterator = (vtkInformationIterator)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIterator.Register(null);
				}
			}
			return vtkInformationIterator;
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationIterator_SetInformation_12(HandleRef pThis, HandleRef arg0);

		public void SetInformation(vtkInformation arg0)
		{
			vtkInformationIterator.vtkInformationIterator_SetInformation_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkCommon.Unmanaged.dll")]
		internal static extern void vtkInformationIterator_SetInformationWeak_13(HandleRef pThis, HandleRef arg0);

		public void SetInformationWeak(vtkInformation arg0)
		{
			vtkInformationIterator.vtkInformationIterator_SetInformationWeak_13(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}
	}
}
