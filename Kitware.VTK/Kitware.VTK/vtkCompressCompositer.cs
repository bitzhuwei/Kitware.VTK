using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkCompressCompositer : vtkCompositer
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompressCompositer";

		public new static readonly string MRClassNameKey;

		static vtkCompressCompositer()
		{
			vtkCompressCompositer.MRClassNameKey = "class vtkCompressCompositer";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompressCompositer.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompressCompositer"));
		}

		public vtkCompressCompositer(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCompressCompositer_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompressCompositer New()
		{
			vtkCompressCompositer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompressCompositer.vtkCompressCompositer_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompressCompositer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkCompressCompositer() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkCompressCompositer.vtkCompressCompositer_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCompressCompositer_CompositeBuffer_01(HandleRef pThis, HandleRef pBuf, HandleRef zBuf, HandleRef pTmp, HandleRef zTmp);

		public override void CompositeBuffer(vtkDataArray pBuf, vtkFloatArray zBuf, vtkDataArray pTmp, vtkFloatArray zTmp)
		{
			vtkCompressCompositer.vtkCompressCompositer_CompositeBuffer_01(base.GetCppThis(), (pBuf == null) ? default(HandleRef) : pBuf.GetCppThis(), (zBuf == null) ? default(HandleRef) : zBuf.GetCppThis(), (pTmp == null) ? default(HandleRef) : pTmp.GetCppThis(), (zTmp == null) ? default(HandleRef) : zTmp.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCompressCompositer_CompositeImagePair_02(HandleRef localZ, HandleRef localP, HandleRef remoteZ, HandleRef remoteP, HandleRef outZ, HandleRef outP);

		public static void CompositeImagePair(vtkFloatArray localZ, vtkDataArray localP, vtkFloatArray remoteZ, vtkDataArray remoteP, vtkFloatArray outZ, vtkDataArray outP)
		{
			vtkCompressCompositer.vtkCompressCompositer_CompositeImagePair_02((localZ == null) ? default(HandleRef) : localZ.GetCppThis(), (localP == null) ? default(HandleRef) : localP.GetCppThis(), (remoteZ == null) ? default(HandleRef) : remoteZ.GetCppThis(), (remoteP == null) ? default(HandleRef) : remoteP.GetCppThis(), (outZ == null) ? default(HandleRef) : outZ.GetCppThis(), (outP == null) ? default(HandleRef) : outP.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCompressCompositer_Compress_03(HandleRef zIn, HandleRef pIn, HandleRef zOut, HandleRef pOut);

		public static void Compress(vtkFloatArray zIn, vtkDataArray pIn, vtkFloatArray zOut, vtkDataArray pOut)
		{
			vtkCompressCompositer.vtkCompressCompositer_Compress_03((zIn == null) ? default(HandleRef) : zIn.GetCppThis(), (pIn == null) ? default(HandleRef) : pIn.GetCppThis(), (zOut == null) ? default(HandleRef) : zOut.GetCppThis(), (pOut == null) ? default(HandleRef) : pOut.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCompressCompositer_IsA_04(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkCompressCompositer.vtkCompressCompositer_IsA_04(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern int vtkCompressCompositer_IsTypeOf_05(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkCompressCompositer.vtkCompressCompositer_IsTypeOf_05(type);
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCompressCompositer_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkCompressCompositer NewInstance()
		{
			vtkCompressCompositer result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompressCompositer.vtkCompressCompositer_NewInstance_07(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompressCompositer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern IntPtr vtkCompressCompositer_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkCompressCompositer SafeDownCast(vtkObjectBase o)
		{
			vtkCompressCompositer vtkCompressCompositer = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkCompressCompositer.vtkCompressCompositer_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompressCompositer = (vtkCompressCompositer)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompressCompositer.Register(null);
				}
			}
			return vtkCompressCompositer;
		}

		[DllImport("Kitware.VTK.vtkParallel.Unmanaged.dll")]
		internal static extern void vtkCompressCompositer_Uncompress_09(HandleRef zIn, HandleRef pIn, HandleRef zOut, HandleRef pOut, int finalLength);

		public static void Uncompress(vtkFloatArray zIn, vtkDataArray pIn, vtkFloatArray zOut, vtkDataArray pOut, int finalLength)
		{
			vtkCompressCompositer.vtkCompressCompositer_Uncompress_09((zIn == null) ? default(HandleRef) : zIn.GetCppThis(), (pIn == null) ? default(HandleRef) : pIn.GetCppThis(), (zOut == null) ? default(HandleRef) : zOut.GetCppThis(), (pOut == null) ? default(HandleRef) : pOut.GetCppThis(), finalLength);
		}
	}
}
