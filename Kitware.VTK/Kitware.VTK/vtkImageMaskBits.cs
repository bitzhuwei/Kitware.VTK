using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkImageMaskBits : vtkThreadedImageAlgorithm
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMaskBits";

		public new static readonly string MRClassNameKey;

		static vtkImageMaskBits()
		{
			vtkImageMaskBits.MRClassNameKey = "class vtkImageMaskBits";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMaskBits.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMaskBits"));
		}

		public vtkImageMaskBits(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMaskBits_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMaskBits New()
		{
			vtkImageMaskBits result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMaskBits.vtkImageMaskBits_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMaskBits)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkImageMaskBits() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkImageMaskBits.vtkImageMaskBits_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMaskBits_GetMasks_01(HandleRef pThis);

		public virtual uint[] GetMasks()
		{
			IntPtr intPtr = vtkImageMaskBits.vtkImageMaskBits_GetMasks_01(base.GetCppThis());
			uint[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new uint[4];
				int[] array2 = new int[4];
				Marshal.Copy(intPtr, array2, 0, array.Length);
				for (int i = 0; i < 4; i++)
				{
					array[i] = (uint)array2[i];
				}
			}
			return array;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMaskBits_GetMasks_02(HandleRef pThis, ref uint _arg1, ref uint _arg2, ref uint _arg3, ref uint _arg4);

		public virtual void GetMasks(ref uint _arg1, ref uint _arg2, ref uint _arg3, ref uint _arg4)
		{
			vtkImageMaskBits.vtkImageMaskBits_GetMasks_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMaskBits_GetMasks_03(HandleRef pThis, IntPtr _arg);

		public virtual void GetMasks(IntPtr _arg)
		{
			vtkImageMaskBits.vtkImageMaskBits_GetMasks_03(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMaskBits_GetOperation_04(HandleRef pThis);

		public virtual int GetOperation()
		{
			return vtkImageMaskBits.vtkImageMaskBits_GetOperation_04(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMaskBits_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkImageMaskBits.vtkImageMaskBits_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern int vtkImageMaskBits_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkImageMaskBits.vtkImageMaskBits_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMaskBits_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkImageMaskBits NewInstance()
		{
			vtkImageMaskBits result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMaskBits.vtkImageMaskBits_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMaskBits)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern IntPtr vtkImageMaskBits_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkImageMaskBits SafeDownCast(vtkObjectBase o)
		{
			vtkImageMaskBits vtkImageMaskBits = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkImageMaskBits.vtkImageMaskBits_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMaskBits = (vtkImageMaskBits)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMaskBits.Register(null);
				}
			}
			return vtkImageMaskBits;
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMaskBits_SetMask_10(HandleRef pThis, uint mask);

		public void SetMask(uint mask)
		{
			vtkImageMaskBits.vtkImageMaskBits_SetMask_10(base.GetCppThis(), mask);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMaskBits_SetMasks_11(HandleRef pThis, uint _arg1, uint _arg2, uint _arg3, uint _arg4);

		public virtual void SetMasks(uint _arg1, uint _arg2, uint _arg3, uint _arg4)
		{
			vtkImageMaskBits.vtkImageMaskBits_SetMasks_11(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMaskBits_SetMasks_12(HandleRef pThis, IntPtr _arg);

		public virtual void SetMasks(IntPtr _arg)
		{
			vtkImageMaskBits.vtkImageMaskBits_SetMasks_12(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMaskBits_SetMasks_13(HandleRef pThis, uint mask1, uint mask2);

		public void SetMasks(uint mask1, uint mask2)
		{
			vtkImageMaskBits.vtkImageMaskBits_SetMasks_13(base.GetCppThis(), mask1, mask2);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMaskBits_SetMasks_14(HandleRef pThis, uint mask1, uint mask2, uint mask3);

		public void SetMasks(uint mask1, uint mask2, uint mask3)
		{
			vtkImageMaskBits.vtkImageMaskBits_SetMasks_14(base.GetCppThis(), mask1, mask2, mask3);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMaskBits_SetOperation_15(HandleRef pThis, int _arg);

		public virtual void SetOperation(int _arg)
		{
			vtkImageMaskBits.vtkImageMaskBits_SetOperation_15(base.GetCppThis(), _arg);
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMaskBits_SetOperationToAnd_16(HandleRef pThis);

		public void SetOperationToAnd()
		{
			vtkImageMaskBits.vtkImageMaskBits_SetOperationToAnd_16(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMaskBits_SetOperationToNand_17(HandleRef pThis);

		public void SetOperationToNand()
		{
			vtkImageMaskBits.vtkImageMaskBits_SetOperationToNand_17(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMaskBits_SetOperationToNor_18(HandleRef pThis);

		public void SetOperationToNor()
		{
			vtkImageMaskBits.vtkImageMaskBits_SetOperationToNor_18(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMaskBits_SetOperationToOr_19(HandleRef pThis);

		public void SetOperationToOr()
		{
			vtkImageMaskBits.vtkImageMaskBits_SetOperationToOr_19(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkImaging.Unmanaged.dll")]
		internal static extern void vtkImageMaskBits_SetOperationToXor_20(HandleRef pThis);

		public void SetOperationToXor()
		{
			vtkImageMaskBits.vtkImageMaskBits_SetOperationToXor_20(base.GetCppThis());
		}
	}
}
