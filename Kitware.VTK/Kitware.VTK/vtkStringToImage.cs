using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public abstract class vtkStringToImage : vtkObject
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkStringToImage";

		public new static readonly string MRClassNameKey;

		static vtkStringToImage()
		{
			vtkStringToImage.MRClassNameKey = "class vtkStringToImage";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStringToImage.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStringToImage"));
		}

		public vtkStringToImage(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern byte vtkStringToImage_GetScaleToPowerOfTwo_01(HandleRef pThis);

		public virtual bool GetScaleToPowerOfTwo()
		{
			return vtkStringToImage.vtkStringToImage_GetScaleToPowerOfTwo_01(base.GetCppThis()) != 0;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkStringToImage_IsA_02(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkStringToImage.vtkStringToImage_IsA_02(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern int vtkStringToImage_IsTypeOf_03(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkStringToImage.vtkStringToImage_IsTypeOf_03(type);
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkStringToImage_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkStringToImage NewInstance()
		{
			vtkStringToImage result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStringToImage.vtkStringToImage_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStringToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern IntPtr vtkStringToImage_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkStringToImage SafeDownCast(vtkObjectBase o)
		{
			vtkStringToImage vtkStringToImage = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkStringToImage.vtkStringToImage_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStringToImage = (vtkStringToImage)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStringToImage.Register(null);
				}
			}
			return vtkStringToImage;
		}

		[DllImport("Kitware.VTK.vtkRendering.Unmanaged.dll")]
		internal static extern void vtkStringToImage_SetScaleToPowerOfTwo_06(HandleRef pThis, byte scale);

		public virtual void SetScaleToPowerOfTwo(bool scale)
		{
			vtkStringToImage.vtkStringToImage_SetScaleToPowerOfTwo_06(base.GetCppThis(), scale ? (byte)1 : (byte)0);
		}
	}
}
