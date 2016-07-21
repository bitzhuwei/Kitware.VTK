using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkZLibDataCompressor : vtkDataCompressor
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkZLibDataCompressor";

		public new static readonly string MRClassNameKey;

		static vtkZLibDataCompressor()
		{
			vtkZLibDataCompressor.MRClassNameKey = "class vtkZLibDataCompressor";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkZLibDataCompressor.MRClassNameKey, Type.GetType("Kitware.VTK.vtkZLibDataCompressor"));
		}

		public vtkZLibDataCompressor(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkZLibDataCompressor_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkZLibDataCompressor New()
		{
			vtkZLibDataCompressor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkZLibDataCompressor.vtkZLibDataCompressor_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkZLibDataCompressor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkZLibDataCompressor() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkZLibDataCompressor.vtkZLibDataCompressor_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkZLibDataCompressor_GetCompressionLevel_01(HandleRef pThis);

		public virtual int GetCompressionLevel()
		{
			return vtkZLibDataCompressor.vtkZLibDataCompressor_GetCompressionLevel_01(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkZLibDataCompressor_GetCompressionLevelMaxValue_02(HandleRef pThis);

		public virtual int GetCompressionLevelMaxValue()
		{
			return vtkZLibDataCompressor.vtkZLibDataCompressor_GetCompressionLevelMaxValue_02(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkZLibDataCompressor_GetCompressionLevelMinValue_03(HandleRef pThis);

		public virtual int GetCompressionLevelMinValue()
		{
			return vtkZLibDataCompressor.vtkZLibDataCompressor_GetCompressionLevelMinValue_03(base.GetCppThis());
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern uint vtkZLibDataCompressor_GetMaximumCompressionSpace_04(HandleRef pThis, uint size);

		public override uint GetMaximumCompressionSpace(uint size)
		{
			return vtkZLibDataCompressor.vtkZLibDataCompressor_GetMaximumCompressionSpace_04(base.GetCppThis(), size);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkZLibDataCompressor_IsA_05(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkZLibDataCompressor.vtkZLibDataCompressor_IsA_05(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkZLibDataCompressor_IsTypeOf_06(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkZLibDataCompressor.vtkZLibDataCompressor_IsTypeOf_06(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkZLibDataCompressor_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkZLibDataCompressor NewInstance()
		{
			vtkZLibDataCompressor result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkZLibDataCompressor.vtkZLibDataCompressor_NewInstance_08(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkZLibDataCompressor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkZLibDataCompressor_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkZLibDataCompressor SafeDownCast(vtkObjectBase o)
		{
			vtkZLibDataCompressor vtkZLibDataCompressor = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkZLibDataCompressor.vtkZLibDataCompressor_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkZLibDataCompressor = (vtkZLibDataCompressor)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkZLibDataCompressor.Register(null);
				}
			}
			return vtkZLibDataCompressor;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern void vtkZLibDataCompressor_SetCompressionLevel_10(HandleRef pThis, int _arg);

		public virtual void SetCompressionLevel(int _arg)
		{
			vtkZLibDataCompressor.vtkZLibDataCompressor_SetCompressionLevel_10(base.GetCppThis(), _arg);
		}
	}
}
